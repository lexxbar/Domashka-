Console.Write("Enter number: ");
int n = Convert.ToInt32(Console.ReadLine());

void Kub(int[] n)
{
  int c = 0;
  int length = n.Length;
  while (c <  length)
  {
    n[c] = Convert.ToInt32(Math.Pow(c, 3));
    c++;
  }
}

void Array(int[] m)
{
  int cunt = m.Length;
  int index = 1;
  while(index < cunt)
  {
    Console.Write(m[index]+ " ");
    index++;
  }
} 

int[] arry = new int [n+1];
Kub(arry);
Array(arry);
