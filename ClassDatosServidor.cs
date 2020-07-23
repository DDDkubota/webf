using System;
using System.IO;

namespace programaweb24
{
    class ClassDatosServidor
    {
        public String server
        { set; get; }
        public String puerto
        { set; get; }
        public String BaseDatos
        { set; get; }
        public String UserDB
        { set; get; }
        public String PassWordDB
        { set; get; }

        static ClassDatosServidor datosservidor;
        public static ClassDatosServidor instancia()
        {
            if (datosservidor == null)
            {
                datosservidor = new ClassDatosServidor();

            }
            return datosservidor;

        }
        public String[] leerdocumento()
        {
            String[] arrary = new string[5];


            StreamReader BDPass = new StreamReader("server.txt");

            arrary[0] = BDPass.ReadLine();
            BDPass.Close();
            StreamReader BDPass2 = new StreamReader("puerto.txt");

            arrary[1] = BDPass2.ReadLine();
            BDPass2.Close();
            StreamReader BDPass3 = new StreamReader("BDname.txt");

            arrary[2] = BDPass3.ReadLine();
            BDPass3.Close();
            StreamReader BDPass4 = new StreamReader("BDuser.txt");

            arrary[3] = BDPass4.ReadLine();
            BDPass4.Close();
            StreamReader BDPass5 = new StreamReader("BDPass.txt");

            arrary[4] = BDPass5.ReadLine();
            BDPass5.Close();
            return arrary;
        }
        public Boolean sobreescribirdocs(String server, String puerto, String Dbname, String dbuser, String sbPass)
        {
            StreamWriter confBD = new StreamWriter("server.txt", false);
            confBD.WriteLine(server);
            confBD.Close();
            StreamWriter confBD2 = new StreamWriter("puerto.txt", false);
            confBD2.WriteLine(puerto);
            confBD2.Close();
            StreamWriter confBD3 = new StreamWriter("BDname.txt", false);
            confBD3.WriteLine(Dbname);
            confBD3.Close();
            StreamWriter confBD4 = new StreamWriter("BDuser.txt", false);
            confBD4.WriteLine(dbuser);
            confBD4.Close();
            StreamWriter confBD5 = new StreamWriter("BDPass.txt", false);
            confBD5.WriteLine(sbPass);
            confBD5.Close();
            StreamReader BDPassR = new StreamReader("server.txt");
            String newserver = BDPassR.ReadLine();
            BDPassR.Close();
            if (newserver == server)
            {
                return true;
            }
            return false;
        }


    }
}
