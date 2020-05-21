
void setup() {
  pinMode(7, OUTPUT);
  digitalWrite(7, LOW);

  Serial.begin(9600);
  Serial.println("Ready");
}

void loop() {
  if (Serial.available() > 0) {
    Serial.read();
    trigger();
  }
}

void trigger() {
  Serial.println("ZAP");
  digitalWrite(7, HIGH);
  delay(300);
  digitalWrite(7, LOW);
  delay(200);
  digitalWrite(7, HIGH);
  delay(600);
  digitalWrite(7, LOW);
}
