using System;

public class Game
{

    public void playGame()
    {

        Wallet wallet = new Wallet();

        int money;
        int cash;

        money = wallet.fillWallet();
        wallet.setWallet(money);
        cash = wallet.getWallet();

        Spin pullLever = new Spin();
        pullLever.spin(wallet);
        Console.WriteLine();
        

    }


}
