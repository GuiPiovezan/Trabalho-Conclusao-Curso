package com.example.kaio01.agenda_aluno;

import android.app.AlertDialog;
import android.content.Intent;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.view.WindowManager;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class TelaLogin extends AppCompatActivity {

    EditText edtEmail, edtSenha;
    SQLiteDatabase db;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.tela_login);
        getSupportActionBar().hide();

        edtEmail=(EditText)findViewById(R.id.edtEmail);
        edtSenha=(EditText)findViewById(R.id.edtSenha);

    }

    public void registrar_clique(View v){
        Intent tela = new Intent(this,TelaEscolha.class);
        startActivity(tela);
    }
    public void entrar_clique(View v) {

        String email = edtEmail.getText().toString();
        String senha = edtSenha.getText().toString();

        if ("".equals(email) || "".equals(senha)) {

            AlertDialog.Builder alerta = new AlertDialog.Builder(this);
            alerta.setTitle("Campo vazio");
            alerta.setMessage("Insira valores em todos os campos!");
            alerta.setNeutralButton("OK", null);
            alerta.show();
        } else {


            Cursor registro = db.query("USUARIOS", null, "EMAIL ='" + email + "' and SENHA = '" + senha + "'", null, null, null, null);
            Usuario user = new Usuario();

            if (registro.moveToNext()) {
                //consultando
                String sql = "SELECT COD_TIPO_USUARIO FROM USUARIOS where EMAIL ='" + email + "'and SENHA = '" + senha + "'";
                registro = db.rawQuery(sql, null);

                //pego os dados

                registro.moveToFirst();
                int tipoUsuario = registro.getInt(0);


                if (tipoUsuario == 1) {
                    Toast.makeText(this, "Bem-vindo, professor !", Toast.LENGTH_SHORT).show();
                    Intent tela = new Intent(getApplicationContext(), TelaPrincipal.class);
                    startActivity(tela);
                } else {
                    Toast.makeText(this, "Bem-vindo, aluno !", Toast.LENGTH_SHORT).show();
                    Intent tela = new Intent(getApplicationContext(), TelaPrincipal.class);
                    startActivity(tela);
                }


            } else {
                Toast.makeText(this, "Email ou senha inválido", Toast.LENGTH_SHORT).show();
            }

        }
    }


}



