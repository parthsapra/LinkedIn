import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class vLocationBase {

//#region cityName Prop
        @gridColumn({visible: true, columnIndex:1, allowSorting: true, headerKey: 'cityName', keyColumn: false})
        cityName : string;
//#endregion cityName Prop


//#region stateName Prop
        @gridColumn({visible: true, columnIndex:2, allowSorting: true, headerKey: 'stateName', keyColumn: false})
        stateName : string;
//#endregion stateName Prop


//#region countryName Prop
        @gridColumn({visible: true, columnIndex:3, allowSorting: true, headerKey: 'countryName', keyColumn: false})
        countryName : string;
//#endregion countryName Prop


//#region cityId Prop
        @gridColumn({visible: true, columnIndex:4, allowSorting: true, headerKey: 'cityId', keyColumn: true})
        cityId : number;
//#endregion cityId Prop

}