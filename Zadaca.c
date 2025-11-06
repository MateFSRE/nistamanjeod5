#include<stdio.h>

void main(){
	
	char Prezime[20];
    char Ime[20];
    int god;
    char studij[20];
    printf("Napisi Svoje Ime "); // Mate pisao
    scanf("%s",&Ime);
    printf("Napisi svoje prezime "); // Bozena pisala
    scanf("%s",&Prezime);
    printf("Napisi koliko godina imas:"); //Ivana pisala
    scanf("%d",&god);
    printf("Napisi sto studiras: "); //Gabrijela pisala
    scanf("%s", &studij);

    printf("Vase Ime Je %s %s , Imate %d godina i studirate %s",Ime,Prezime,god,studij); // Mate pisao
}
