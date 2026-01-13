graph TD
    %% Core Loop ของเกม HighLow
    Action[1. พิมพ์ตัวเลขทาย] --> Feedback[2. รับคำใบ้ มากไป/น้อยไป]
    Feedback --> Analyze[3. วิเคราะห์/ตัดตัวเลือก]
    Analyze -->|ยังไม่ถูก| Action
    Feedback -->|ทายถูก| Win((ชนะเกม!))

    stateDiagram-v2
    %% จุดเริ่มต้น
    [*] --> SetupState

    state SetupState {
        note: สุ่มเลข 1-100\nรีเซ็ตข้อความ
    }
    SetupState --> PlayState : เริ่มเกม

    state PlayState {
        note: รอผู้เล่นพิมพ์เลข\nและกดปุ่ม
    }
    PlayState --> CheckState : กด Submit

    state CheckState {
        note: ตรวจคำตอบ
    }
    CheckState --> PlayState : ผิด (ใบ้ผล)
    CheckState --> WinState : ถูกต้อง (Win)

    state WinState {
        note: แสดงความยินดี\nปุ่ม Restart
    }
    WinState --> SetupState : กดเล่นใหม่

    graph TD
    %% Actors
    Player((👤 ผู้เล่น))
    
    %% Components
    subgraph Unity Scene
        InputUI[🟦 Input Field]
        TextUI[🟦 Result Text]
        ButtonUI[🟦 Submit Button]
    end

    subgraph Scripts
        Controller[⚙️ GameController.cs]
    end

    %% Flow การทำงาน
    Player -->|1. พิมพ์เลข| InputUI
    Player -->|2. คลิก| ButtonUI
    
    ButtonUI -.->|3. เรียกฟังก์ชัน| Controller
    InputUI -.->|4. ดึงค่าตัวเลข| Controller
    
    Controller -->|5. ประมวลผล| Controller
    
    Controller -->|6. อัปเดตข้อความ| TextUI
    TextUI -.->|7. แสดงผล| Player
