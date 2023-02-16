import { createActionGroup, props } from "@ngrx/store";

export const ApplicationEvents = createActionGroup({
    source: 'Application Events',
    events: {
        'error': props<{ message: string }>()
    }
})