package com.example.kaio01.agenda_aluno;

/**
 * Created by LABINFO on 18/04/2019.
 */
public class Usuario {

    private String EMAIL;
    private String SENHA;
    private String NOME;
    private String DATA_NASC;
    private String TELEFONE;

    private int _ID_USUARIO;
    private int COD_TIPO_USUARIO;



    public String getEMAIL() {
        return EMAIL;
    }

    public void setEMAIL(String EMAIL) {
        this.EMAIL = EMAIL;
    }

    public String getSENHA() {
        return SENHA;
    }

    public void setSENHA(String SENHA) {
        this.SENHA = SENHA;
    }

    public String getNOME() {
        return NOME;
    }

    public void setNOME(String NOME) {
        this.NOME = NOME;
    }

    public String getDATA_NASCIMENTO() {
        return DATA_NASC;
    }

    public void setDATA_NASC(String DATA_NASC) {
        this.DATA_NASC = DATA_NASC;
    }

    public String getTELEFONE() {
        return TELEFONE;
    }

    public void setTELEFONE(String TELEFONE) {
        this.TELEFONE = TELEFONE;
    }

    public int getID_USUARIO() {
        return _ID_USUARIO;
    }

    public void setID_USUARIO(int ID_USUARIO) {
        this._ID_USUARIO = ID_USUARIO;
    }

    public int getCOD_TIPO_USUARIO() {
        return COD_TIPO_USUARIO;
    }

    public void setCOD_TIPO_USUARIO(int COD_TIPO_USUARIO) {
        this.COD_TIPO_USUARIO = COD_TIPO_USUARIO;
    }



}
