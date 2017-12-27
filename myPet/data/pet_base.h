#ifndef PET_BASE_H
#define PET_BASE_H


class pet_base
{
    public:
        pet_base();
        virtual ~pet_base();

        unsigned int GetpetHunger() { return petHunger; }
        void SetpetHunger(unsigned int val) { petHunger = val; }
        unsigned int GetpetAge() { return petAge; }
        void SetpetAge(unsigned int val) { petAge = val; }
        std::string GetpetName() { return petName; }
        void SetpetName(std::string val) { petName = val; }
        int GetpetHappy() { return petHappy; }
        void SetpetHappy(int val) { petHappy = val; }
        int GetpetPoop() { return petPoop; }
        void SetpetPoop(int val) { petPoop = val; }






    protected:

    private:
        unsigned int petHunger;
        unsigned int petAge;
        std::string petName;
        int petHappy;
        int petPoop;
};

#endif // PET_BASE_H
