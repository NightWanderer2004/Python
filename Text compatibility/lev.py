def dist(a,b):
	def rec(i,x):
		if i == 0 or x == 0:
			return max(i,x)
		elif a[i-1] == b[x-1]:
			return rec(i-1,x-1)
		else:
			return 1+min(
				rec(i,x-1),
				rec(i-1,x),
				rec(i-1,x-1),
				)
	return rec(len(a),len(b))
str1="Working"
str2="Gnikrow"
lev=dist(str1,str2)
bigger=max([len(str1),len(str2)])
pct=((bigger-lev)/bigger)*100
print("{str1}\n{str2}\n===\nСхожесть:{pct}%".format(str1=str1,str2=str2,pct=pct))