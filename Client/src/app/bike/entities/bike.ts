import { Status } from "../enums/status.enum";
import { Type } from "../enums/type.enum";

export class Bike {
    constructor(
        public id?: number,
        public title?: string,
        public type?: Type,
        public price?: number,
        public status?: Status) { }
}
