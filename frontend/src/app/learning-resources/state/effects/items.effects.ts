import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Actions, createEffect, ofType } from "@ngrx/effects";
import { map, switchMap } from "rxjs";
import { itemsDocuments } from "../actions/items.actions";
import { learningResourcesEvents } from "../actions/learning-resources.actions";
import { ItemEntity } from "../reducers/items.reducer";


@Injectable()
export class ItemsEffects {

    loadItemsOnFeatureEntered$ = createEffect(() => {
        return this.actions$.pipe(
            ofType(learningResourcesEvents.entered),
            switchMap(() => this.client.get<{ items: ItemEntity[] }>('http://localhost:1337/resources')
                .pipe(
                    map(response => response.items),
                    map(payload => itemsDocuments.items({ payload }))
                )
            )
        )
    })

    constructor(private actions$: Actions, private client: HttpClient) { }
}

type ItemResponseFromServer = {
    items: ItemEntity[]
}