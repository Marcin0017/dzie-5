int number = 4566;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();

int count0 = 0;
int count1 = 0;
int count2 = 0;
int count3 = 0;
int count4 = 0;
int count5 = 0;
int count6 = 0;
int count7 = 0;
int count8 = 0;
int count9 = 0;

foreach(char letter in letters)
{
    if (letter == '0')
    {
        count0++;
    }
    else if(letter == '1')
    {
        count1++;
    }
    else if (letter == '2')
    {
        count2++;
    }
    else if(letter == '3')
    {
        count3++;
    }
    else if(letter == '4')
    {
        count4++;
    }
    else if(letter == '5')
    {
        count5++;
    }
    else if (letter == '6')
    {
        count6++;
    }
    else if(letter == '7')
    {
        count7++;
    }
    else if(letter == '8')
    {
        count8++;
    }
    else if(letter == '9')
    {
        count9++;
    }

}



