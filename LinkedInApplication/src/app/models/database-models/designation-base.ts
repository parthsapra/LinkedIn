import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class DesignationBase {

//#region designationId Prop
        @prop()
        designationId : number;
//#endregion designationId Prop


//#region userId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        userId : number;
//#endregion userId Prop


//#region designationName Prop
        @required()
        @maxLength({value:50})
        designationName : string;
//#endregion designationName Prop


//#region startMonthYear Prop
        @required()
        startMonthYear : Date;
//#endregion startMonthYear Prop


//#region endMonthYear Prop
        @required()
        endMonthYear : Date;
//#endregion endMonthYear Prop

}