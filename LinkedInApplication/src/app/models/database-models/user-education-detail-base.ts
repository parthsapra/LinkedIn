import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class UserEducationDetailBase {

//#region userEducationDetailId Prop
        @prop()
        userEducationDetailId : number;
//#endregion userEducationDetailId Prop


//#region userId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        userId : number;
//#endregion userId Prop


//#region schoolName Prop
        @required()
        @maxLength({value:50})
        schoolName : string;
//#endregion schoolName Prop


//#region degreeName Prop
        @required()
        @maxLength({value:50})
        degreeName : string;
//#endregion degreeName Prop


//#region fieldofStudy Prop
        @required()
        @maxLength({value:50})
        fieldofStudy : string;
//#endregion fieldofStudy Prop


//#region startYear Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        startYear : number;
//#endregion startYear Prop


//#region endYear Prop
        @prop()
        endYear : number;
//#endregion endYear Prop


//#region grade Prop
        @maxLength({value:50})
        grade : string;
//#endregion grade Prop


//#region activities Prop
        @prop()
        activities : string;
//#endregion activities Prop


//#region description Prop
        @prop()
        description : string;
//#endregion description Prop

}