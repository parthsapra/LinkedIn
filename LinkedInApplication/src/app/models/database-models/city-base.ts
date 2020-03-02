import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class CityBase {

//#region cityId Prop
        @prop()
        cityId : number;
//#endregion cityId Prop


//#region stateId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        stateId : number;
//#endregion stateId Prop


//#region cityName Prop
        @required()
        @maxLength({value:50})
        cityName : string;
//#endregion cityName Prop

}