import android.content.Context;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;
//import android.util.Log;

public class BancoDados extends SQLiteOpenHelper
{
   private static final String NOME_BANCO = "BDAgenda";
   private static final int VERSAO = 1;

    public CriaBanco (Context context)
    {
        super(context, NOME_BANCO, null, VERSAO);
    }

    @Override
    public void onCreate(SQLiteDatabase bd)
    {
        String sql;
        sql = "CREATE TABLE ESCOLA (ID_escola INTEGER PRIMARY KEY AUTOINCREMENT, nome_unidade NOT NULL TEXT, endereco_unidade NOT NULL TEXT, email_unidade NOT NULL TEXT, telefone_unidade NOT NULL, TEXT);";
        sql = "CREATE TABLE CURSO (ID_curso INTEGER PRIMARY KEY AUTOINCREMENT, tipo NOT NULL TEXT, periodo NOT NULL TEXT, coordenador NOT NULL TEXT, ano NOT NULL TEXT,COD_curso_escola INTEGER, FOREIGN KEY (COD_curso_escola) REFERENCES ESCOLA (ID_escola));";
        sql = "CREATE TABLE TURMA (ID_turma INTEGER PRIMARY KEY AUTOINCREMENT, COD_curso INTEGER NOT NULL, nome_turma NOT NULL TEXT, FOREIGN KEY (COD_curso) REFERENCES CURSO (ID_curso);";
        SQL = "CREATE TABLE DISCENTE (ID_discente INTEGER PRIMARY KEY AUTOINCREMENT, nome_discente NOT NULL TEXT, data_nasc DATE, telefone_discente NOT NULL TEXT, " +
                ")"
    }

}
