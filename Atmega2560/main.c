/*
 * Lab_2_Atmega2560.c
 *
 * Created: 22.02.2020 15:50:12
 * Author : Serhii-PC
 */ 
#define F_CPU 16000000UL
#include <avr/io.h>
#include <util/delay.h>
#include <avr/interrupt.h>
#define LED_ON(port, pin) ((port) |= (1 << (pin)))
#define LED_OFF(port, pin) ((port) &= ~(1 << (pin)))
#define READ_PINL(pin) ((1 << (pin))&PINL)
#define BAUD 9600
#define UBRR_CALC (F_CPU/(BAUD*16L) - 1)
#define DELAY_LED_MS 550
#define ALGORITHM_5 0x5
#define ALGORITHM_8 0x8

void algorithm_5();
void algorithm_8();
uint8_t tmpRX;

void SetupUSART0()
{
	//Dual speed mode off:
	UCSR0A = 0;
	//interruption of reception, receiver, transmitter:
	UCSR0B = (1 << RXCIE0)|(1 << RXEN0)|(1 << TXEN0);
	//8 bit, no parity, 1 stop bit:
	UCSR0C = (1 << UCSZ01)|(1 << UCSZ00);
	//speed : 9600 bps:
	UBRR0H = (uint8_t)(UBRR_CALC >> 8);
	UBRR0L = (uint8_t)(UBRR_CALC);	 
}

ISR(USART0_RX_vect)
{
	tmpRX = UDR0;
}

int main(void)
{
    DDRA = 0xFF;
    DDRL = 0x00;
	tmpRX = 0x00;
	SetupUSART0();
	sei();
    while (1) 
    {
		if(READ_PINL(PL3)){
			UDR0 = ALGORITHM_5;
			_delay_ms(300);
		}
		if(READ_PINL(PL5)){
			UDR0 = ALGORITHM_8;
			_delay_ms(300);	
		}
		_delay_ms(100);
		if(tmpRX == ALGORITHM_5){
			algorithm_5();
			tmpRX = 0x00;
		}
		_delay_ms(100);
		if(tmpRX == ALGORITHM_8){
			algorithm_8();
			tmpRX = 0x00;
		}
    }
	return 0;
}

void algorithm_5()
{
	for(int8_t pin = 0;pin < 8; pin += 2){
		LED_ON(PORTA, pin);
		_delay_ms(DELAY_LED_MS);
		LED_OFF(PORTA, pin);
		if(pin == 6)
			pin = -1;
	}
}

void algorithm_8()
{
	uint8_t pin = 7;
	int8_t k = 7;
	int8_t sign = 1;
	while(k >= 0){
		LED_ON(PORTA, pin);
		_delay_ms(DELAY_LED_MS);
		LED_OFF(PORTA, pin);
		sign *= -1;
		pin += k*sign;
		--k;
	}
}