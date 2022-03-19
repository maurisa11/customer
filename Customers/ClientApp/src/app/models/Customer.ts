import { GenericEntity } from "./GenericEntity";

export class Customer extends GenericEntity {
	FirstName: string;
	LastName: string;
	AddressLine: string;
  Gender: number;
	Email: string;
}