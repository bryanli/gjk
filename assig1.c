/* Fig. 3.6: fig03_06.c
   Class average program with counter-controlled repetition */
#include <stdio.h>

/* function main begins program execution */
int main( void )
{
   int counter; /* number of grade to be entered next */
   int grade; /* grade value */
   int total; /* sum of grades input by user */
   int average; /* average of grades */
   
   /* initialization phase */
   total = 0; /* initialize total */
   counter = 0; /* initialize loop counter */   
   grade = 0;/* initialize grade*/
   
   printf("Enter positive grade, exit the program by entering a negative number\n");
   
   /* processing phase */
  
   while(grade >= 0) { /*repeat program is grade is positive*/
      printf( "Enter grade: " ); /* prompt for input */
      scanf( "%d", &grade ); /* read grade from user */
     
      if (grade >= 0 && grade <= 100) {/*execute if grade is between 0 to 100*/
	total = total + grade; /* add grade to total */
	counter = counter + 1; /* increment counter */
      }/* end if*/
     
      if (grade > 100) {/* error message if grade is bigger than 100*/
	printf("the maximum grade is 100\n");/* print error message*/
      }/* end if*/
      
   } 
   /* end while */
   if (counter ==0){
     printf("not enough data\n");
   }else{
   
   /* termination phase */
   average = total / counter; /* integer division */

   printf( "Class average is %d\n", average ); /* display result */
   }

   return 0; /* indicate program ended successfully */
} /* end function main */






