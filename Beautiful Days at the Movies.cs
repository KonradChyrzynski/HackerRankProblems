public static int beautifulDays(int i, int j, int k)
{
    int sum = 0;
    for(; i <= j; i++ )
    {
        int reversed = Int32.Parse(string.Join("",i.ToString().Select(x => x - 48).Reverse().ToArray()));
        
        if((i - reversed) % k == 0)
        {
            sum++;
        }
    }
    
    return sum;
}