string[] primordial_massive = { "hello", "2", "world", ":-)" };
string[] final_massive = new string[primordial_massive.Length];
int count = 0;
int number = 3; //меньше трех
for (int i = 0; i < primordial_massive.Length; i++)
    if (primordial_massive[i].Length <= number)
    {
        final_massive[count] = primordial_massive[i];
        count++;
    }
