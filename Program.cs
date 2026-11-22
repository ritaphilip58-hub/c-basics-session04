#region Q1
double[] prices = { 25.5, 40.0, 33.75, };
Console.WriteLine(prices[1]);
#endregion

#region Q2
int[,] shelfCopies ={
{ 3 ,5},
{1,4 },

};
Console.WriteLine(shelfCopies[1,0]);
#endregion

#region Q3
void PrintWelcomeMessage()
{
    Console.WriteLine("Welcome to the Library!");
}
PrintWelcomeMessage();
#endregion

#region Q4
void PrintBookTitle(string title)
{
    Console.WriteLine($"Book title: " + title );
}
PrintBookTitle("clean code");
#endregion

#region Q5
void AddBonusPages(int pages)
{
    pages += 50;
}
int pages = 400;
AddBonusPages ( pages);
Console.WriteLine(pages);//the method changes copy of pages,original unchanged
#endregion

#region Q6
void ApplyDiscount(double[]prices6) {
    prices6[0]-= 5.0;
}
double[]prices6 = {25.5,40.0};
ApplyDiscount(prices6);
Console.WriteLine(prices6[0]);
#endregion

#region Q7
void AddBonusPagesByRef(ref int pages7){

    pages7 += 50;
}
int pages7 = 400;
AddBonusPagesByRef(ref pages7);
Console.WriteLine(pages7);
#endregion

#region Q8
void ReplaceArray(ref double[] prices){
    prices= new double []{ 10.0, 12.5, 15.0 };
}
double[] prices8 = { 500.0, 40.5 };
ReplaceArray(ref prices8);
Console.WriteLine(prices8.Length);
#endregion

#region Q9
bool TryGetPrice(string title, out double price9)
{
    if (title == "clean code")
    {
        price9 = 25.5;
        return true;
    }
    else
    {
        price9 = 0;
        return false;
    }
}
    if(TryGetPrice("clean code", out double price))
    {
        Console.WriteLine(price);
    }

#endregion

#region Q10,11
void PrintBookInfo(string title, int pages = 300)
{
    Console.WriteLine($"Title {title} pages {pages} ");
}
PrintBookInfo("clean code");
PrintBookInfo("clean code", 500);
PrintBookInfo(pages: 800, title:"clean code");
#endregion

void PrintAllTitles (params string[] titles)
{
    foreach (string title in titles)
    {
        Console.WriteLine(title);
    }
}
PrintAllTitles("hamlet","love story","clean code" );

