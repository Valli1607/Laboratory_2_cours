double a = 0.1, b = 1;
double e = 0.0001;
double k = 10,n=10;
double step = (b - a) / k;
for(int i = 0; i <= k; i++)
{
    double x = a + i * step;
    double r = Math.Sin(x);
    double s1 = 0;
    double xn = x;
    for(int j = 0; j <= n; j++)
    {
        if (j == 0)
        {
            xn = x;
        }
        else
        {
            xn *= -x * x / ((2 * j) * (2 * j + 1));
        }
        s1 += xn;
    }
    double s2 = 0;
    double xe=x;
    int t = 0;
    s2 += xe;
    t++;
    xe *= -x * x / ((2 * t) * (2 * t + 1));
    /*for (int j=1; Math.Abs(xe) > e;j++)
    {
        s2 += xe;
        xe*= -x * x / ((2 * j) * (2 * j + 1));
    }
    s2 += xe;
    Console.WriteLine($"X = {x:F2}\tSN = {s1:F8}\tSE = {s2:F8}\tY = {r:F8}");
    */
    while (Math.Abs(xe) > e)
    {
        s2 += xe;
        t++;
        xe *= -x * x / ((2 * t) * (2 * t + 1));
    }
    Console.WriteLine($"X = {x:F2}\tSN = {s1:F8}\tSE = {s2:F8}\tY = {r:F8}");
}