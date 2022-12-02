BEGIN { score1=0;
	score2=0;
	value1="ABC";
	value2="XYZ"; 
      }
	{
		f = (index(value1,$1))-1;
		s = (index(value2,$2))-1;
        score1 += ((f+1) %3 == s)*6 + (f==s)*3 + s + 1;
        score2 += (s == 0)*((f+2) % 3 + 1) + (s == 1)*(f+4) + (s == 2)*((f+1) % 3 + 7);
	}
END {
	print "Task 1 : " score1;
	print "Task 2 : " score2;
}
