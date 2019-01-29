using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UFCheckArchive
{
    public class UFCheckArchiveController
    {
        private DBConn _dbConn;                                              // 数据库连接串
        DateTime _dtNow;                                                    // 当前时间（需要读数据库时间）
        private List<CheckItem> _listCheckItem = new List<CheckItem>();     // 检查项model列表



        public DateTime DtNow
        {
            get { return _dtNow; }
        }

        public List<CheckItem> CheckItemList
        {
            get { return _listCheckItem; }
        }


        /// <summary>
        /// Controller构造函数
        /// </summary>
        public UFCheckArchiveController()
        {
            // 从配置文件读取数据库连接串
            _dbConn = DBConn.LoadDBConn();

            // 读取数据库时间
            try
            {
                _dtNow = Util.GetDBDate(_dbConn);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format(@"获取数据库当前日期失败: {0}", ex.Message));
            }


            // 读取配置(要替换成数据库时间)
            _listCheckItem = CheckItem.LoadCheckItemList(_dtNow);
        }


        /// <summary>
        /// 设置开始或结束
        /// </summary>
        /// <param name="checkItem"></param>
        /// <param name="isRunning"></param>
        public void SetItemRunningStatus(CheckItem checkItem, bool isRunning)
        {
            checkItem.IsRunning = isRunning;
        }


        /// <summary>
        /// 检查单个条目
        /// </summary>
        /// <param name="checkItem"></param>
        public void StartCheckItem(CheckItem checkItem,DateTime dt)
        {
            /* 1.读数据库日期，判断
             * 2.读状态，判断
             * 3.读额外表
             */



            string connStr = string.Format(@"Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST={0})(PORT={1}))(CONNECT_DATA=(SERVICE_NAME={2}))));Persist Security Info=True;User ID={3};Password={4};",
                                                _dbConn.IP,
                                                _dbConn.Port,
                                                _dbConn.Service,
                                                _dbConn.User,
                                                _dbConn.Password
                                                );

            // 读当前表
            using (OracleConnection conn = new OracleConnection(connStr))
            {
                conn.Open();
                using (OracleCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = string.Format(@"select count(1) from {0} where {1}='{2}'", checkItem.CurTable.Table, checkItem.CurTable.DateColumn, dt.ToString("yyyyMMdd"));
                    object res = cmd.ExecuteScalar();

                    checkItem.CurTable.ActualValue = res.ToString().Trim();
                }
            }



            // 读历史表
            using (OracleConnection conn = new OracleConnection(connStr))
            {
                conn.Open();
                using (OracleCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = string.Format(@"select count(1) from {0} where {1}='{2}'", checkItem.HisTable.Table, checkItem.HisTable.DateColumn, dt.ToString("yyyyMMdd"));
                    object res = cmd.ExecuteScalar();

                    checkItem.HisTable.ActualValue = res.ToString().Trim();
                }
            }


            checkItem.IsChecked = true;
            checkItem.UpdateNote();

        }



        public bool IsAllOK()
        {
            foreach (CheckItem checkItem in _listCheckItem)
            {
                if (!checkItem.IsCheckPassed)
                    return false;
            }

            return true;
        }

    }
}
