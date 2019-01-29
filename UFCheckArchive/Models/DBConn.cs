using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

namespace UFCheckArchive
{
    public class DBConn
    {
        private string _ip;
        private string _port;
        private string _service;
        private string _instance;
        private string _user;
        private string _pwd;

        public string IP
        {
            get { return _ip; }
        }

        public string Port
        {
            get { return _port; }
        }

        public string Service
        {
            get { return _service; }
        }

        public string Instance
        {
            get { return _instance; }
        }

        public string User
        {
            get { return _user; }
        }

        public string Password
        {
            get { return _pwd; }
        }




        public DBConn(string ip, string port, string service, string instance, string user, string pwd)
        {
            _ip = ip;
            _port = port;
            _service = service;
            _instance = instance;
            _user = user;
            _pwd = pwd;
        }



        public static DBConn LoadDBConn()
        {
            DBConn dbConn = null;


            // 判断配置文件是否存在，不存在抛出异常
            if (!File.Exists(Path.Combine(Environment.CurrentDirectory, "cfg.xml")))
                throw new Exception("未能找到配置文件cfg.xml，请重新配置该文件后重启程序!");

            // 读取配置文件
            XmlDocument doc = new XmlDocument();
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreComments = true;                                     //忽略文档里面的注释
            using (XmlReader reader = XmlReader.Create(@"cfg.xml", settings))
            {
                doc.Load(reader);

                // 检查根节点
                XmlNode rootNode = doc.SelectSingleNode("Config");   // 根节点
                if (rootNode == null)
                    throw new Exception("无法找到根配置节点<Config>，请检查配置文件格式是否正确!");


                // 获取检查项列表
                XmlNode xnDBConn = rootNode.SelectSingleNode("DBConn");
                if (xnDBConn == null)
                    throw new Exception("无法找到检查项列表节点<Config>-<DBConn>，请检查配置文件格式是否正确!");


                // 临时变量
                string ip = string.Empty;
                string port = string.Empty;
                string server = string.Empty;
                string instance = string.Empty;
                string user = string.Empty;
                string pwd = string.Empty;
                // 遍历项
                foreach (XmlNode xn in xnDBConn.ChildNodes)
                {
                    switch (xn.Name.Trim())
                    {
                        case "IP":
                            ip = xn.InnerText.Trim();
                            break;
                        case "Port":
                            port = xn.InnerText.Trim();
                            break;
                        case "Service":
                            server = xn.InnerText.Trim();
                            break;
                        case "Instance":
                            instance = xn.InnerText.Trim();
                            break;
                        case "User":
                            user = xn.InnerText.Trim();
                            break;
                        case "Pwd":
                            pwd = xn.InnerText.Trim();
                            break;
                    }
                }//eof foreach
                dbConn = new DBConn(ip: ip, port: port, service: server, instance: instance, user: user, pwd: pwd);

            }//eof using

            return dbConn;
        }
    }
}
