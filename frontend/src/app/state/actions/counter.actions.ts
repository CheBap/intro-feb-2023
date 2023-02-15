import { createActionGroup, emptyProps, props } from "@ngrx/store";
import { counterState } from "../reducers/counter.reducer";


export const counterEvents = createActionGroup({
    source: 'Counter Events',
    events: {
        'Count Incremented': emptyProps(),
        'Count Decremented': emptyProps(),
        'Count Reset': emptyProps(),
        'Count By Set': props<{ by: CountByValues }>(),
        'Counter Entered': emptyProps()
    }
})

export const counterDocuments = createActionGroup({
    source: 'CounterDocuments',
    events: {
        'counter': props<{ payload: counterState }>()
    }
})

export type CountByValues = 1 | 3 | 5;