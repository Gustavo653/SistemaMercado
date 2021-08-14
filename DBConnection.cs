using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMercado
{
    public static class DBConnection
    {
        //public static SqlConnection Connection { get; set; } = new SqlConnection("Data Source=BUE205D12;Initial Catalog=BDTurmaManha;User ID=guest01;Password=@Senac2021");
        public static SqlConnection Connection { get; set; } = new SqlConnection("Data Source=DESKTOP-VE6HMRL;Initial Catalog=master;Integrated Security=True");

        public static void Executa(string comando)
        {
            SqlCommand cmd = new SqlCommand(comando, Connection);
            Connection.Open();
            cmd.ExecuteNonQuery();
            Connection.Close();
        } 

        //codigo para o BD de login
        //        Create Table dbo.Usuarios(
        //idUsuario int not null identity(1, 1),
        //        usuario varchar(max) not null,
        //        senha varchar(max) not null
        //        )
        //        INSERT into dbo.Usuarios(usuario, senha) values('Admin', '887375DAEC62A9F02D32A63C9E14C7641A9A8A42E4FA8F6590EB928D9744B57BB5057A1D227E4D40EF911AC030590BBCE2BFDB78103FF0B79094CEE8425601F5')

        //codigo para o BD de produtos
        //        Create Table dbo.Produtos(
        //idProduto int not null identity(1,1),
        //nome varchar(50) not null,
        //quantidade int not null,
        //preco decimal not null
        //)
    }
}
