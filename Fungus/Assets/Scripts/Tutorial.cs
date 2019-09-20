using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    // O metodo Start eh chamado ao criar o objeto com esse script no jogo.
    void Start()
    {
        //Imprimindo um texto no console (costuma aparecer perto da parte que tem os arquivos, o console)
        print("Hello, World!");

        //criar variavel
        // estrutura: 'tipoDaVariavel' 'nomeDaVariavel' '=' 'ValorInicialDaVariavel' ';'
        //exemplos de tipo: string, int, float, Vector3
        string primeiraVariavel = "Caina ";
        string textoPraConcatenar = "eh um bom professor";

        // concatenação:
        print(primeiraVariavel + textoPraConcatenar + ".\nVc nao acha?");

        //matematicas

        var meuDouble = 10.5; // declarando double, mas usando 'var'

        float meuFloat = 20.3f; // float eh numero com virgula, soh que usa menos espaço na memoria que um double.
                                //tem que colocar um 'f' depois de um numero float pro compilador entender que eh float e nao double.

        print(meuDouble * meuFloat);
        // alem de multiplicacao ( * ) temos: + - /

        //variavel booleana
        bool celularFazContas = true;
        bool dispositivo2FazContas = false;
        // && eh a mesma coisa que o operador 'e' ; || eh a mesma coisa que o operador 'ou'
        print("operacao ou: " + (celularFazContas || dispositivo2FazContas)); // se um dos dois for True, resultado eh True
        print("operacao e: "  + (celularFazContas && dispositivo2FazContas)); // resultado eh true soh se os dois operandos forem True
        print("operacao 'nao'" + (!celularFazContas)); //o resultado eh o oposto do operando. !True == False , !False == True

        //concicionais
        if (dispositivo2FazContas) {
            //soh vai executar isso se o dispositivo2FazContas
            print("O dispositivo 2 faz contas. Yeah");
        } else if (celularFazContas) {
            print("Tah, tranquilo: o celular faz a conta... ufa");
        } else {
            print("Lascou! Como vamos fazer a conta? Socorroooooooo");
            //nessa situacao, nenhum dos dispositivos faz contas
        }

        var meuInt = 0;

        switch (meuInt) {
            case 0:
                print("meu Int vale 0");
                break;
            case 1:
                print("meu Int vale 1");
                break;
            case 2:
                print("meu Int vale 2");
                break;
            case 3:
                print("meu Int vale 3");
                break;
            default:
                print("meu Int vale um negocio que eu nao estava esperando");
                break;
        }

        /* Input no C# puro seria feiro assim, mas na Unity eh outra história.
         * Os Inputs mais comum na Unity são: Input.GetKey("tecla") exemplo: Input.GetKey("w") para saber
         * se a tecla 'w' está sendo pressionada. Input.GetMouseButton(0) para saber se o botão esquerdo
         * do mouse está sendo pressionado. E também se usam muito os botões, que são um componente (Button),
         * e fazem parte do sistema de UI (User Interface) da Unity.
        //input no C# puro:
        string testString;
        testString = Console.ReadLine();
        print("Input coletado " + testString);
        */



        int iterador = 5;
        // mais opções: > , < , >= , <= , == (igual), != (diferente)
        while (iterador > 0) {
            print("Repetindo com while: " + iterador);
            iterador = iterador - 1; // eh igual a escrever iterador--;
        }
        print("eu saí do loop, yeah");

        for (int i = 6 ; i > 0 ; i-- /*i = i+1*/) {
            print("Repetindo com for: " + i);
        }

        /*obs: na Unity não se usa loop com tanta frequência no começo, porque geralmente o que deve
         * se repetir eh colocado no metodo Update, que executa varias vezes por segundo.
        */

        // criando vetor
        int[] meus5Numeros = {2,4,3,2,5};
        int[] numeros = new int[999];

        // usa um elemento do vetor
        print(numeros[2]);

        numeros[2] = 4; // modifica um elemento do vetor
        print(numeros[2]);

        //quantos elementos tem no vetor?
        print(numeros.Length);

        //funcoes!
        /* podemos criar funcoes, que eh quase um sinonimo de metodos, para fazer varias operacoes
         de uma vez soh. Perceba que a linha abaixo vai executar varias impressoes. Confira a definicao
         dessa funcao lah mais para o fim do codigo, por favor, para ver onde foi definido o que ela faria.*/
        ImprimeVariasCoisas();

        /*Alem de fazer varias coisas de uma vez soh, funcoes podem retornar um resultado para a gente.
        A funcao CriaVetor esta retornando um vetor de numeros inteiros. Confira tambem a definicao lah mais abaixo
         */
        int[] vetorCriadoComFuncao = CriaVetor();
        print(vetorCriadoComFuncao.Length);

        /*funcoes tambem podem receber parametros para que considerem eles quando vao executar.
         * veja soh: essa funcao Soma3Numeros recebe 3 parametros x,y,z e retorna a soma deles.
         * */
        int x = 1; int y = 2; int z = 9;
        int soma = Soma3Numeros(x,y,z);
        print("3 numeros somados com funcao: " + soma);

        //classes:
        /*classes sao formadas por atributos e metodos, e sao ótimas para dividir o programa, e não
         * ficar um codigo grande demais em um único arquivo. Para esse tutorial, criei mais classes
         * no mesmo arquivo, mas geralmente se faz uma classe por arquivo!
         * 
         * Classes conceitualmente sao moldes para objetos, que tem suas caracteristicas (atributos)
         * e as coisas que o objeto eh capaz de fazer (seus metodos).
         * 
         * Confira a definicao da classe Guerreiro lah mais no final desse arquivo, e então acompanhe
         * aqui a criacao e utilizacao de um objeto dessa classe.
         * */

        //criando um objeto
        Guerreiro caina = new Guerreiro();

        //alterando atributos publicos
        caina.ataque = 20;
        caina.vida = 100;

        // usando atributo publico
        print(caina.ataque);

        //criando mais um guerreiro
        Guerreiro guerreiro = new Guerreiro( "Joao" );

        print("vida do " + guerreiro.nome + ": " + guerreiro.vida);

        caina.Atacar(guerreiro);

        print("vida do " + guerreiro.nome + ": " + guerreiro.vida); //vida reduziu depois do ataque.

        //criando objeto da subclasse Berseker, que herda de Guerreiro
        Berseker brutus = new Berseker("Brutus");

        brutus.Atacar(guerreiro);

        print("vida do " + guerreiro.nome + ": " + guerreiro.vida);

        print("nome do berseker: " + brutus.nome);
    }

    // Update eh chamada uma vez por frame. Ou seja, umas 30 vezes por segundo.
    void Update () {
        //mas nao estamos pedindo para que nada seja feito 30 vezes por segundo xD
    }

    //criando funcao
    static void ImprimeVariasCoisas () {
        print("imprimir um negocio");
        print("imprimir um negocio");
        print("imprimir um negocio");
        print("imprimir um negocio");
        print("imprimir um negocio");
        print("imprimir um negocio");
        print("imprimir um negocio");
    }

    //funcao com retorno
    static int[] CriaVetor () {
        int[] vet = new int[5];
        return vet;
    }

    //criamos funcao com parametros e retorno.
    static int Soma3Numeros (int n1 , int n2 , int n3) {
        int variavel = n1+n2+n3;
        return variavel;
        //return n1+n2+n3;
    }


}

//criando uma classe
public class Guerreiro {
    //atributos
    public int vida;
    public int ataque;
    public string nome;

    //construtor
    public Guerreiro () {
        vida = 100;
        ataque = 20;
    }

    public Guerreiro (string nomeDoGuerreiro) {
        this.nome = nomeDoGuerreiro;
        vida = 100;
        ataque = 20;
    }

    //metodos ...
    public virtual void Atacar (Guerreiro g) {
        g.vida = g.vida - ataque;
    }
}

//criando subclasse Berseker, que herda de guerreiro
public class Berseker : Guerreiro {
    //construtor da subclasse chama o construtor da superclasse
    public Berseker () : base() {

    }

    //construtor da subclasse chama o construtor da superclasse com um parametro
    public Berseker (string name) : base(name) {

    }

    //escreve sobre o metodo da superclasse com palavra chave override
    public override void Atacar (Guerreiro g) {
        base.Atacar(g);
        base.Atacar(g);
    }
}
