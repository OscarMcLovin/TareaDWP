#include <SPI.h>
#include <RH_ASK.h>
RH_ASK radio;




void setup() {
  // put your setup code here, to run once:
radio.init();

}

void loop() {
  // put your main code here, to run repeatedly:
uint8_t buf[1];
uint8_t buflen= sizeof(buf);

if(radio.recv(buf, &buflen)){
  serial.print("El mensaje es:");
  serial.println((char *)buf);
  if((char *)buf=='1'){
    digitalWrite(led, !digitalRead(led));
  }
}
}
