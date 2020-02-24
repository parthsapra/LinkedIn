import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class UserDetailBase {

//#region userDetailId Prop
        @prop()
        userDetailId : number;
//#endregion userDetailId Prop


//#region userId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        userId : number;
//#endregion userId Prop


//#region gender Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        gender : number;
//#endregion gender Prop


//#region profilePhoto Prop
        @prop()
        profilePhoto : string;
//#endregion profilePhoto Prop


//#region birthDate Prop
        @prop()
        birthDate : Date;
//#endregion birthDate Prop


//#region connectionCount Prop
        @prop()
        connectionCount : number;
//#endregion connectionCount Prop


//#region cityId Prop
        @prop()
        cityId : number;
//#endregion cityId Prop


//#region stateId Prop
        @prop()
        stateId : number;
//#endregion stateId Prop


//#region countryId Prop
        @prop()
        countryId : number;
//#endregion countryId Prop


//#region headline Prop
        @maxLength({value:50})
        headline : string;
//#endregion headline Prop

}