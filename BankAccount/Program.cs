using System;

// README.md를 읽고 아래에 코드를 작성하세요.


BankAccount bankacc = new BankAccount("123-456", "홍길동");
Console.WriteLine($"계좌번호: {bankacc.AccountNumber}");
Console.WriteLine($"예금주: {bankacc.OwnerName}");
Console.WriteLine($"잔액: {bankacc.Balance}원");
Console.WriteLine("--- 50000원 입금 ---");
bankacc.Deposit(50000);
Console.WriteLine($"잔액: {bankacc.Balance}원");
Console.WriteLine("--- 20000원 출금 ---");
Console.WriteLine($"출금 성공: {bankacc.Withdraw(20000)}");
Console.WriteLine($"잔액: {bankacc.Balance}원");
Console.WriteLine("--- 100000원 출금 시도 ---");
Console.WriteLine($"출금 성공: {bankacc.Withdraw(100000)}");
Console.WriteLine($"잔액: {bankacc.Balance}원");


class BankAccount
{
    private string _accountNumber;
    private string _ownerName;
    private int _balance;

    public BankAccount(string accountNumber, string ownerName)
    {
        _accountNumber = accountNumber;
        _ownerName = ownerName;
        _balance = 0;
    }
    public string AccountNumber 
    {
        get { return _accountNumber; }
    }

    
    public string OwnerName 
    {
        get { return _ownerName; }
        set { _ownerName = value; }
    }

    public int Balance
    {
        get { return _balance; }
    }

    public void Deposit(int amount)
    {
        if (amount < 0)
           return;

        _balance += amount;
    }

    public bool Withdraw(int amount)
    {
        if (amount <= 0)
            return false;

        if (_balance < amount)
            return false;

        _balance -= amount;
            return true;    
    }


}