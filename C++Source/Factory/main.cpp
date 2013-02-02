#include <stdio.h>
#include <iostream>


class POperation
{
public:
	double m_first;
	double m_secend;
	virtual double getResult()
	{
		double result = 0;
		return result;
	
	}
};


class OperationAdd:public POperation
{
public:
	virtual double getResult()
	{
		return m_first +m_secend;
	}
};

class OperationSub:public POperation
{
public :
	virtual double getResult()
	{
		return m_first- m_secend;
	}
};

class CreateFactory
{
public:
	static POperation *CreateOpertion(char cmd)
	{
		switch(cmd)
		{
		case '+':
			{
				return new OperationAdd();
				break;
			}
		case '-':
			{
				return new OperationSub();
				break;
			}
		default:
			break;
		}
		return NULL;
	
	}

	
};


int main()
{
	int a,b;
	char c;
	while(1)
	{
		std::cin>>a>>b;
		std::cin>>c;
		POperation *m_pOperation = CreateFactory::CreateOpertion(c);
		m_pOperation->m_first = a;
		m_pOperation->m_secend = b;
		std::cout<<m_pOperation->getResult();
	
	}

	
	return 0;
}