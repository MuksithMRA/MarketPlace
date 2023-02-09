import { User } from "./user";

export interface LoginResponse {
    userDTO: User;
    token: string;
    message: string;
    statusCode: number;
}
