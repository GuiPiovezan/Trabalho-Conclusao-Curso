package com.example.kaio01.agenda_aluno;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;

public class TelaEscolha extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.tela_escolha);
        getSupportActionBar().hide();
    }
    public void aluno_clique(View v){
        Intent tela = new Intent(this,TelaCadastroAluno.class);
        startActivity(tela);
    }
    public void professor_clique(View v){
        Intent tela = new Intent(this,TelaCadastroProfessor.class);
        startActivity(tela);
    }
}
