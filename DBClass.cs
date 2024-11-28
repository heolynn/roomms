using System;
using System.Data;
using Oracle.DataAccess.Client;//ADO.Net 개체 참조
using System.Windows.Forms;

public class DBClass
{

    OracleConnection con;
    OracleCommand dcom;
    OracleDataAdapter da; // Data Provider인 DBAdapter 입니다.

    DataSet ds; // DataSet 객체입니다.
    OracleDataReader dr; // DataReader 객체입니다.
    OracleCommandBuilder myCommandBuilder; // 추가, 수정, 삭제시에 필요한 명령문을 자동으로 작성해주는 객체입니다.
    DataTable phoneTable; // DataTable 객체입니다.

    public OracleConnection Con { get { return con; } set { con = value; } }
    public OracleCommand DCom { get { return dcom; } set { dcom = value; } }
    public OracleDataAdapter DA { get { return da; } set { da = value; } }
    public OracleDataReader DR { get { return dr; } set { dr = value; } }
    public DataSet DS { get { return ds; } set { ds = value; } }
    public OracleCommandBuilder MyCommandBuilder { get { return myCommandBuilder; } set { myCommandBuilder = value; } }
    public DataTable PhoneTable { get { return phoneTable; } set { phoneTable = value; } }

    public void DB_Open()
    {
        try
        {
            string connectionString = "User Id=hongsing; Password=1111; Data Source=(DESCRIPTION =   (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))   (CONNECT_DATA =     (SERVER = DEDICATED)     (SERVICE_NAME = xe)   ) );";

            string commandString = "select * from room";
            DA = new OracleDataAdapter(commandString, connectionString);
            MyCommandBuilder = new OracleCommandBuilder(DA);

            DS = new DataSet();

        }
        catch (DataException DE)
        {
            MessageBox.Show(DE.Message);
        }
    }

    public void DB_Access()
    {
        try
        {
            string My_con = "User Id=hongsing; Password=1111; Data Source=(DESCRIPTION =   (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))   (CONNECT_DATA =     (SERVER = DEDICATED)     (SERVICE_NAME = xe)   ) );";

            Con = new OracleConnection();
            Con.ConnectionString = My_con;
            DCom = new OracleCommand();
            DCom.Connection = Con;
            Con.Open();
        }
        catch (DataException DE)
        {
            MessageBox.Show(DE.Message);
        }
    }

    public void DB_ObjCreate()
    {
        PhoneTable = new DataTable();
    } 
}
