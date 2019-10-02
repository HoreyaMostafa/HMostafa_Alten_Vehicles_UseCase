export interface Vehicle {
  id: number;
  vin: string;
  regnr: string;
  customerId: number;
  customerName: string;
  lastSeen: Date;
  isConnected: Boolean;
}
