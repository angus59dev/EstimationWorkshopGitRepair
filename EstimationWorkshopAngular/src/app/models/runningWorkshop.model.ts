export interface RunningWorkshopModel {
    title: string;
    users: WorkshopUser[]
}

export interface WorkshopUser {
    name: string;
    connected: boolean;
    voted: boolean; 
}

