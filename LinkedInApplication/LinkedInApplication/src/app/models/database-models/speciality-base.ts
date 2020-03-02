import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class SpecialityBase {

//#region specialityId Prop
        @prop()
        specialityId : number;
//#endregion specialityId Prop


//#region specialityName Prop
        @required()
        @maxLength({value:50})
        specialityName : string;
//#endregion specialityName Prop


//#region companyId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        companyId : number;
//#endregion companyId Prop

}