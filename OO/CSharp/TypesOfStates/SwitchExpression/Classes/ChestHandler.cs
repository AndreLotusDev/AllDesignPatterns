namespace SwitchExpression.Classes
{
    public static class ChestHandler
    {
        public static Chest.EStatus Manipulate(Chest.EAction action, Chest.EStatus status, bool haveTheKey)
        => (action, status, haveTheKey) switch
            {
                (Chest.EAction.Open, Chest.EStatus.Unlock, false) => status = Chest.EStatus.Unlock,
                (Chest.EAction.Open, Chest.EStatus.Unlock, true) => status = Chest.EStatus.Unlock,
                (Chest.EAction.Open, Chest.EStatus.Lock, true) => status = Chest.EStatus.Unlock,
                (Chest.EAction.Open, Chest.EStatus.Lock, false) => status = Chest.EStatus.Lock,
                
                (Chest.EAction.Close, Chest.EStatus.Unlock, true) => status = Chest.EStatus.Lock,
                (Chest.EAction.Close, Chest.EStatus.Unlock, false) => status = Chest.EStatus.Lock,
                (Chest.EAction.Close, Chest.EStatus.Lock, true) => status = Chest.EStatus.Lock,
                (Chest.EAction.Close, Chest.EStatus.Lock, false) => status = Chest.EStatus.Lock,
                
                _ => status
            };
    }
}
