#include <SPI.h>
#include <RH_ASK.h>
RH_ASK radio();
int boton=3;

void setup() {
  // put your setup code here, to run once:
  radio.init ();
pinMode(boton, INPUT_PULLUP);

}

void loop() {
  // put your main code here, to run repeatedly:
  if(digitalRead(boton==LOW){
    const char *msg="1";
  }const char *msg="Hola k hace la bandiux";
radio.send((uint8_t *)msg, strlen(msg));
radio.waitPacketSent();
delay(1000);
}
}
