import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class vCityBase {

//#region cityId Prop
        @gridColumn({visible: true, columnIndex:1, allowSorting: true, headerKey: 'cityId', keyColumn: true})
        cityId : number;
//#endregion cityId Prop


//#region cityName Prop
        @gridColumn({visible: true, columnIndex:2, allowSorting: true, headerKey: 'cityName', keyColumn: false})
        cityName : string;
//#endregion cityName Prop

}