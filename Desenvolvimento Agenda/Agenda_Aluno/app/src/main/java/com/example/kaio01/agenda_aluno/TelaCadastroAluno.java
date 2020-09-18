package com.example.kaio01.agenda_aluno;

import android.app.AlertDialog;
import android.content.ContentValues;
import android.content.Intent;
import android.database.sqlite.SQLiteDatabase;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.view.WindowManager;
import android.widget.EditText;
import android.widget.Toast;

public class TelaCadastroAluno extends AppCompatActivity {

    //Declarando objetos da tela
    EditText edtNome, edtEmail, edtDataNasc, edtSenha, edtConfirmaSenha, edtTelefone;
    CriaBanco bdAgenda;
    SQLiteDatabase db;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.tela_cadastro_aluno);
        getSupportActionBar().hide();

        //Referenciando objetos da tela
        edtNome = (EditText)findViewById(R.id.edtNome);
        edtEmail = (EditText)findViewById(R.id.edtEmail);
        edtTelefone = (EditText)findViewById(R.id.edtTelefone);
        edtDataNasc= (EditText)findViewById(R.id.edtDataNasc);
        edtSenha = (EditText)findViewById(R.id.edtSenha);
        edtConfirmaSenha = (EditText)findViewById(R.id.edtConfirmaSenha);

          bdAgenda = new CriaBanco(getApplicationContext());
          db = bdAgenda.getWritableDatabase();

    }

    public void registro_clique(View v){

        Usuario aluno = new Usuario();


        String nome = edtNome.getText().toString();
        String email = edtEmail.getText().toString();
        String telefone = edtTelefone.getText().toString();
        String dataNasc = edtDataNasc.getText().toString();
        String senha = edtSenha.getText().toString();
        String confirma = edtConfirmaSenha.getText().toString();


    if(nome.equals("") || email.equals("") || telefone.equals("") || dataNasc.equals("") || senha.equals("") || confirma.equals("")) {
        AlertDialog.Builder alerta = new AlertDialog.Builder(this);
        alerta.setTitle("Campo vazio");
        alerta.setMessage("Insira valores em todos os campos!");
        alerta.setNeutralButton("OK", null);
        alerta.show();
    }else {

        aluno.setNOME(nome);
        aluno.setSENHA(senha);
        aluno.setDATA_NASC(dataNasc);
        aluno.setEMAIL(email);
        aluno.setTELEFONE(telefone);
        aluno.setCOD_TIPO_USUARIO(2);

        if (aluno.getSENHA().equals(confirma)) {

            ContentValues registro = new ContentValues();
            registro.put("NOME", aluno.getNOME());
            registro.put("SENHA", aluno.getSENHA());
            registro.put("DATA_NASC",aluno.getDATA_NASCIMENTO());
            registro.put("EMAIL", aluno.getEMAIL());
            registro.put("TELEFONE",aluno.getTELEFONE());
            registro.put("COD_TIPO_USUARIO",aluno.getCOD_TIPO_USUARIO());



            //comando insert
            db.insert("USUARIOS", null, registro);


            Toast mensagem = Toast.makeText(getApplicationContext(), "Aluno Cadastrado com Sucesso !", Toast.LENGTH_SHORT);
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
