import random

chars='qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM1234567890'

number=int(input('How many passwords:'))
lenght=int(input('How many symbols:'))

for x in range(number):
	password=''

	for i in range(lenght):
		password += random.choice(chars)
	print(password)
	file=open('pass.txt','a')
	file.write('\n'+password)
	file.close()