# BTBW-PoisonQueues

Simple demo of handling errors in queues
- Contains an obvious buglet
- Some of the test data below passes, some fails
- After 5 failures, the data will end up on a poison queue
- PoisonQueueReader can be used to fix the data and re-queue the items

#### Test Data
```
{
    "CardNumber": "5105105105105100",
    "Expiry": "12/20",
    "Amount": 10.00
}
```
```
{
    "CardNumber": "4111111111111111",
    "Expiry": "12/2021",
    "Amount": 10.00
}
```
```
{
    "CardNumber": "4000120000001154",
    "Expiry": "12/2020",
    "Amount": 0.10
}
```
```
{
    "CardNumber": "4000160000004146",
    "Expiry": "12/2020",
    "Amount": 10.00
}
```
