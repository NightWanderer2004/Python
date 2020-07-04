index=input("m/d/v:\n")
if index =='m':
	d=float(input("Плотность:"))
	v=float(input("Объём:"))
	result=d*v
elif index =='d':
	m=float(input("Масса:"))
	v=float(input("Объём:"))
	result=m/v
elif index =='v':
	m=float(input("Масса:"))
	d=float(input("Плотность:"))
	result=m/d
print("Результат:"+"%.2f"%result)