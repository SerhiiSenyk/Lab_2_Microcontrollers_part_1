;
; Lab_2_ATmega2560_Assembler.asm
;
; Created: 04.12.2020
; Author : Serhii Senyk
;

.nolist
.include "m2560def.inc"
.list
.def _temp1 = r16
.def _temp2 = r17
.def _temp3 = r18
.def _temp4 = r19
.def _algo_io = r20
.def _algo_count = r23
.def _algo_register = r28
;=================FLASH=====================
		.CSEG;interrupts vector
		.org 0x00
	rjmp initial	
		.org URXC0addr
	rjmp USART0_RX_vect;Timer1

USART0_RX_vect:
	in _temp1, SREG
	push _temp1
	lds _algo_register, UDR0
	pop _temp1
	out SREG, _temp1
reti
;--------------------------------------------------------------------
initial:
	ldi	_temp1, low(RAMEND)
	out SPL, _temp1
	ldi _temp1, high(RAMEND)
	out SPH, _temp1
	;Setting ports
	ldi _temp1, 0xFF
	ldi _temp2, 0x00
	out DDRA, _temp1;0xFF
	out PORTA, _temp2;0x00
	ldi _temp1, (1 << PL3)|(1 << PL5) 
	sts DDRL, _temp2;0x00
	sts PORTL, _temp1
	sts UCSR0A, _temp2
	ldi _temp1, (1 << RXCIE0)|(1 << RXEN0)|(1 << TXEN0)
	sts UCSR0B, _temp1
	ldi _temp1, (1 << UCSZ01)|(1 << UCSZ00)
	;Freq 3.6864 MHz, Baud rate 9600
	sts UCSR0C, _temp1
	sts UBRR0H, _temp2
	ldi _temp1, 0x17
	sts UBRR0L, _temp1
	;---------------------
	clr _temp1
	clr _temp2
	clr _temp3
	clr _temp4
	clr _algo_io
	clr _algo_count
	sei 
;----------------------------------------------------------------
main:	
	lds	_temp2, PINL
	sbrc _temp2, PL3
	rjmp next_button
	rcall delay
	lds	_temp2, PINL
	sbrs _temp2, PL3
	rcall button1_pressed
next_button:
	lds	_temp2, PINL
	sbrc _temp2, PL5
	rjmp algo
	rcall delay
	lds	_temp2, PINL
	sbrs _temp2, PL5
	rcall button2_pressed
    algo:
	cpi _algo_register, 0x05
	breq algo3
	cpi _algo_register, 0x08
	breq algo5
rjmp main


algo3:
	ldi _algo_io, 1
	next:
		out PORTA, _algo_io
		mov _algo_count, _algo_io
		lsl _algo_io
		lsl _algo_io
		cpi _algo_count, (1 << 6)
		brne end3
		ldi _algo_io, 2
	end3:
		rcall delay
		cpi _algo_io, 0
		brne next
		clr _algo_register
ret

algo5:
	ldi _algo_io, (1 << 7)
	ldi _algo_count, 8
	ldi _temp3, 1
	mov _temp4, _algo_io
	next8:
		out PORTA, _algo_io
		dec _algo_count
		sbrs _algo_count, 0
		rjmp right
		mov _algo_io, _temp3
		lsl _temp3
		rjmp end
		right:
			lsr _temp4
			mov _algo_io, _temp4	
	 end:
		 rcall delay
		 cpi _algo_count, 0
		 brne next8
		 clr _algo_register
ret

button1_pressed:
	ldi _temp1, 0x05
	sts UDR0, _temp1	
ret

button2_pressed:
	ldi _temp1, 0x08
	sts UDR0, _temp1	
ret

		   
delay:       
	ldi r24, 255      
	ldi r25, 255
	ldi r26, 5
	del:                
		subi r24, 1       
		sbci r25, 0          
		sbci r26, 0  
	brcc del     
ret 