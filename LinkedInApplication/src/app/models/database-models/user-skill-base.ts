import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class UserSkillBase {

//#region userSkillId Prop
        @prop()
        userSkillId : number;
//#endregion userSkillId Prop


//#region userId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        userId : number;
//#endregion userId Prop


//#region userSkillName Prop
        @required()
        @maxLength({value:50})
        userSkillName : string;
//#endregion userSkillName Prop

}