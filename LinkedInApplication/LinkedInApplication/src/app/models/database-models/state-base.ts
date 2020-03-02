import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class StateBase {

//#region stateId Prop
        @prop()
        stateId : number;
//#endregion stateId Prop


//#region stateName Prop
        @required()
        @maxLength({value:50})
        stateName : string;
//#endregion stateName Prop


//#region countryId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        countryId : number;
//#endregion countryId Prop

}