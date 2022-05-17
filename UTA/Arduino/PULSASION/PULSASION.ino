volatile int memoria;
int ant;
const int LED =13;
void setup() {
  Serial.begin(9600);
  attachInterrupt(digitalPinToInterrupt(2),boton ,RISING);
}

void loop() {
  pinMode(LED,OUTPUT);
  if(ant != memoria){
    pinMode(LED,OUTPUT);
    Serial.println(memoria);
    ant=memoria;
    digitalWrite(LED, HIGH);
  }
}
void boton(){
  memoria++;
}
