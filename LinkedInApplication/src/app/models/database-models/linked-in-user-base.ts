import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class LinkedInUserBase {

//#region lIUserId Prop
        @prop()
        lIUserId : number;
//#endregion lIUserId Prop


//#region lIFirstName Prop
        @required()
        @maxLength({value:50})
        lIFirstName : string;
//#endregion lIFirstName Prop


//#region lILastName Prop
        @required()
        @maxLength({value:50})
        lILastName : string;
//#endregion lILastName Prop


//#region lIRegistrationDate Prop
        @required()
        lIRegistrationDate : any;
//#endregion lIRegistrationDate Prop


//#region lIEmailId Prop
        @maxLength({value:50})
        lIEmailId : string;
//#endregion lIEmailId Prop


//#region lIMobileNumber Prop
        @maxLength({value:12})
        lIMobileNumber : string;
//#endregion lIMobileNumber Prop


//#region isActive Prop
        @prop()
        isActive : boolean;
//#endregion isActive Prop


//#region password Prop
        @required()
        @maxLength({value:50})
        password : any;
//#endregion password Prop


//#region salt Prop
        @maxLength({value:140})
        salt : any;
//#endregion salt Prop













}