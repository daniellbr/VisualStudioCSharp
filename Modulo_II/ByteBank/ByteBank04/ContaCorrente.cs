﻿using System.Configuration;

class ContaCorrente
{
    public string titular;
    public int agencia;
    public int numeroConta;
    public double saldo = 100;

    public bool Sacar(double valor)
    {
        if (this.saldo <= valor)
            return false;

        this.saldo -= valor;
        return true;
    }


    public string Depositar(double valor)
    {
        this.saldo += valor;
        return "Deposito efetuado com Sucesso de " + valor + ". Seu saldo agora é : " + this.saldo;
    }

    public bool Transferir(double valor, ContaCorrente contaDestino)
    {
        if (this.saldo <= valor)
            return false;

        this.Sacar(valor);
        contaDestino.Depositar(valor);
        return true;

    }
}