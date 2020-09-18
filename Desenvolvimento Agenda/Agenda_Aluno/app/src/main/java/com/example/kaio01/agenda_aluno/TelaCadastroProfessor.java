package com.example.kaio01.agenda_aluno;

import android.app.AlertDialog;
import android.content.ContentValues;
import android.content.Intent;
import android.database.sqlite.SQLiteDatabase;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.Toast;

public class TelaCadastroProfessor extends AppCompatActivity {
    EditText edtNome, edtEmail, edtDataNasc, edtSenha, edtConfirmaSenha, edtTelefone;
    CriaBanco bdAgenda;
    SQLiteDatabase db;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.tela_cadastro_professor);
        getSupportActionBar().hide();


    }

    public void registro_clique(View v){
        Usuario professor = new Usuario();


        String nome = edtNome.getText().toString();
        String email = edtEmail.getText().toString();
        String telefone = edtTelefone.getText().toString();
        String dataNasc = edtDataNasc.getText().toString();
        String senha = edtSenha.getText().toString();
        String confirma = edtConfirmaSenha.getText().toString();


        if(nome.equals("") || email.equals("") || telefone.equals("") || dataNasc.equals("") || senha.equals("")) {
            AlertDialog.Builder alerta = new AlertDialog.Builder(this);
            alerta.setTitle("Campo vazio");
            alerta.setMessage("Insira valores em todos os campos!");
            alerta.setNeutralButton("OK", null);
            alerta.show();
        }else {

            professor .setNOME(nome);
            professor .setSENHA(senha);
            professor .setDATA_NASC(dataNasc);
            professor .setEMAIL(email);
            professor .setTELEFONE(telefone);
            professor .setCOD_TIPO_USUARIO(1);

            if (professor .getSENHA().equals(confirma)) {

                ContentValues registro = new ContentValues();
                registro.put("NOME", professor .getNOME());
                registro.put("SENHA", professor .getSENHA());
                registro.put("DATA_NASCIMENTO",professor .getDATA_NASCIMENTO());
                registro.put("EMAIL", professor .getEMAIL());
                registro.put("TELEFONE",professor .getTELEFONE());
                registro.put("COD_TIPO_USUARIO",professor .getCOD_TIPO_USUARIO());



                //comando insert
                db.insert("USUARIOS", null, registro);


                Toast mensagem = Toast.makeText(getApplicationContext(), "Professor Cadastrado com Sucesso !", Toast.LENGTH_SHORT);
                mensagem.show();
                Intent tela = new Intent(getApplicationContext(), TelaLogin.class);
                startActivity(tela);
                finish();
            } else {
                Toast mensagem = Toast.makeText(getApplicationContext(), "Senha não confere!", Toast.LENGTH_SHORT);
                mensagem.show();
            }
        }
    }

}
