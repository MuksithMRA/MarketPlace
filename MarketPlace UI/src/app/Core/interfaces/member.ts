import { Location } from "./location";

export interface Member {
    id: number,
    firstName: string;
    lastName: string;
    locationId: number;
    phoneNumber: number;
    locationDTO: Location;
}
