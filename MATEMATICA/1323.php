<?php

/*
 * URI Online Judge | 1323 https://www.urionlinejudge.com.br/judge/pt/problems/view/1323
 * Primo Rápido
 * Autor: Wiusmarques Moreira dos Reis
 * Contato: wiusmarques.dev@outlook.com
 */

$_1323 = new _1323();

class _1323 {

    public function __construct(){
        $this->execute();
    }

    private function execute(){
        
        while(true){
            $input = readline();

            if($input == 0){
                break;
            }

            $squares = 0;

            for($i = 1; $i <= $input; $i++){
                $squares += $i * $i;
            }

            echo("$squares\n");

        }

    }
}

 ?>