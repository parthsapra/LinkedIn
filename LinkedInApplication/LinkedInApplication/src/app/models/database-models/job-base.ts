import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class JobBase {

//#region jobId Prop
        @prop()
        jobId : number;
//#endregion jobId Prop


//#region companyId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        companyId : number;
//#endregion companyId Prop


//#region jobTitle Prop
        @required()
        @maxLength({value:50})
        jobTitle : string;
//#endregion jobTitle Prop


//#region designation Prop
        @required()
        @maxLength({value:50})
        designation : string;
//#endregion designation Prop


//#region profille Prop
        @required()
        @maxLength({value:50})
        profille : string;
//#endregion profille Prop


//#region experience Prop
        @prop()
        experience : number;
//#endregion experience Prop


//#region description Prop
        @required()
        description : string;
//#endregion description Prop


//#region jobLocationCityId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        jobLocationCityId : number;
//#endregion jobLocationCityId Prop


//#region jobLocationStateId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        jobLocationStateId : number;
//#endregion jobLocationStateId Prop


//#region skills Prop
        @required()
        skills : string;
//#endregion skills Prop


//#region jobCreateDate Prop
        @prop()
        jobCreateDate : Date;
//#endregion jobCreateDate Prop

}