import { Member } from "./member";

export interface User {
    id: number;
    email: string;
    role: string;
    password: string;
    memberId: string;
    memberDTO: Member;
}
