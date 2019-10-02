export interface Vehicle {
  id: number;
  vin: string;
  regnr: string;
  customerId: number;
  lastSeen: Date;
  isConnected: Boolean;
}
