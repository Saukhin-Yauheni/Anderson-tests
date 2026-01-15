# Andersen-tests Saukhin-C#
Here is there solutions on test tasks:

[Task_1] 
Make up an algorithm 
If the entered number is greater than 7, then print “Hello” 
If the entered name matches “John”, then output “Hello, John”, if not, then output "There is no such name" 
There is a numeric array at the input, it is necessary to output array elements that are multiples of 3 

Task 1 console screenshots:
<img width="1108" height="259" alt="image" src="https://github.com/user-attachments/assets/d551578f-5e80-45ce-83d7-87c1fcdb3187" />
<img width="1108" height="327" alt="image" src="https://github.com/user-attachments/assets/4eaec5ca-55a1-4a79-98a5-b3cb958d16f3" />

[Task_2]
Answer the questions 
Given bracket sequence: [((())()(())]] 
Can this sequence be considered correct? 
If the answer to the previous question is “no”, then what needs to be changed in it to make it correct? 

Task 2: 
No,  sequence not correct - because not all of brackets are closed, also we don't have full specifitaion for this task;
Possible solutions:
1:   changing one of the last "]" to rounded ")" [((())()(()))] 
2:   in case if sequence of some empty spec. was supposed to see solution just in rounded brackets deleting all "[","]" and adding one rounded bracket in the end ")" - ((())()(())) ;
3:   adding one opening bracket "[" and closing ")" - [[((())()(()))]] ;
4:   [((())()(())]] in case of deleting on of the last "]" then bracket would be incorrect - [((())()(())] 
